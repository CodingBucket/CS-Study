num = 1234
reverse_num = 0

while num != 0:
    reminder = num % 10
    reverse_num = reverse_num * 10 + reminder
    num = num // 10

print(reversed_num)

print(str(num)[::-1]) # Another way

