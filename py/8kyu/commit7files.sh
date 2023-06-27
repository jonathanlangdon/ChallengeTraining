#!/bin/bash

# Assuming your 0staging folder is in the same directory as the script.
# If not, please replace ./0staging with the correct path.

# Counter for the number of files processed
count=0

# Check if there are any files in the 0staging folder
if [ -n "$(ls -A ./0staging)" ]; then
  for file in $(ls ./0staging | head -n 7); do
    # Get the first line of the file in the 0staging directory
    comment=$(head -n 1 ./0staging/"$file")

    # Move the file to the current directory
    mv ./0staging/"$file" .

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
sleep 7
