#!/bin/bash

# Fetch the latest events for my github account
events=$(curl -s https://api.github.com/users/jonathanlangdon/events)

# Get today's date in the format used by GitHub timestamps
today=$(date -u +"%Y-%m-%dT")

# Check for any PushEvent today
if echo "$events" | jq -e '.[] | select(.type == "PushEvent" and .created_at | startswith("'"$today"'"))' > /dev/null; then
  echo "PushEvent found for today. Exiting script."
  exit 0
fi

# Generate a random number either 1 or 5
# max_files=$(( ( RANDOM % 2 ) * 4 + 1 ))
max_files=1

# Counter for the number of files processed
count=0

# Sleep for a random interval between 1 and 30 minutes
sleep_time=$((RANDOM % 1740 + 60)) # This generates a random number between 60 and 1800
echo "Sleeping for $sleep_time seconds."
# sleep $sleep_time

# Check if there are any files in the 0staging folder
if [ -n "$(ls -A ./0staging)" ]; then
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
    git add .
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
