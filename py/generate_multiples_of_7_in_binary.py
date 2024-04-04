import re

# Start with an empty string for the regex list
regex_list = ""
# Loop to generate the binary multiples of 7
for i in range(1, 100000):
    # Append the binary representation of the multiple of 7, enclosed with ^ and $, to the regex list
    regex_list += "^" + bin(i * 7)[2:] + "$|"

# Remove the last extra pipe character from the regex string
regex_list = regex_list[:-1]

# Compile the regular expression
solution = re.compile(regex_list)

# Save the regex to a text file
file_path = "regex_solution.txt"
with open(file_path, "w") as file:
    file.write(regex_list)

print(f"Regex stored in {file_path}")
