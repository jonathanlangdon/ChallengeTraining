#!/bin/bash

# Get the comment for the file to commit 
read -p "Github comment: " comment
git add .
git commit -m "$comment"
git push
sleep 5
