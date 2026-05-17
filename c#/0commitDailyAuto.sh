#!/bin/bash

todayMidnightUTC=$(TZ="America/New_York" date -d "today 00:00:00" "+%s")
echo "Today New York midnight timestamp is $todayMidnightUTC"

events=$(curl -s https://api.github.com/users/jonathanlangdon/events)
eventDateString=$(echo "$events" | jq -r '.[0].created_at')
echo "The most recent GitHub event in UTC was $eventDateString"

gitHubEvent=$(date -u -d "$eventDateString" "+%s")

if [ "$gitHubEvent" -ge "$todayMidnightUTC" ]; then
    echo "the most recent event is today in New York time. Exiting script."
    exit 0
else
    echo "the most recent event was before today in New York time"
fi

# Generate a random number either 1 or 2
max_files=$(( ( RANDOM % 2 ) * 1 + 1 ))

# Counter for the number of files processed
count=0

# Check if there are any files in the 0staging folder
if [ -n "$(ls -A ./0staging)" ]; then
  # Count the number of files in the 0staging folder
  file_count=$(ls -1 ./0staging | wc -l)
  echo "There are $file_count files in the 0staging folder."

  # If the number of files is less than 5, set max_files to 1
 # if [ $file_count -lt 5 ]; then
 #   max_files=1
 # fi

  # Directly iterate over the files in the directory
  for file in ./0staging/*; do
    # Only process up to the max_files
    if [ $count -eq $max_files ]; then
      break
    fi

    # Get the filename without the directory part
    filename=$(basename "$file")

    # Get the first line of the file in the 0staging directory
    comment=$(head -n 1 "$file")

    # Move the file to the current directory
    mv -i "$file" .

    # Commit the change and push it to the remote repository
    git add "./$filename"
    git add -u "./0staging/$filename"
    git commit -m "$comment"
    git push
    sleep 2

    # Increase the counter
    ((count++))
  done

  echo "$count files were processed."
else
  echo "No files found in the 0staging directory"
fi
