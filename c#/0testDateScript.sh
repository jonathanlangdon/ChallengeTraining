#!/bin/bash

todayESTMidnight=$(TZ="America/New_York" date +"%Y-%m-%d 00:00:00")
echo "Today EST midnight is" $todayESTMidnight
todayMidnightUTC=$(date -u -d "$todayESTMidnight - 3 hours" "+%s")

events=$(curl -s https://api.github.com/users/jonathanlangdon/events)
eventDateString=$(echo "$events" | jq -r '.[0].created_at')
echo "The last push event in UTC was $eventDateString"
gitHubEvent=$(date -u -d "$eventDateString" "+%s")
# "2024-05-09T03:59:59Z" # sample date/time for event


if [ $gitHubEvent -ge $todayMidnightUTC ]; then
    echo "the most recent post is today"
else
    echo "the most recent post was yesterday"
fi