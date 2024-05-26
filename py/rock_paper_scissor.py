# return rock paper scissor winner

def rps(p1, p2):
    p1_wins = [3, -1, -2]
    result = ord(p1[0]) - ord(p2[0])
    return "Draw!" if result == 0 else f"Player {1 if result in p1_wins else 2} won!"


print(rps("s", "p")) #Player 1 won!
print(rps("s", "r")) #Player 2 won!
print(rps("p", "p")) #Draw!
# 3, -1, -2 = player 1
# -3, 1, 2 = player 2
# 0 = "Draw!"

''' another creative solution:
def rps(p1, p2):
    hand = {'rock':0, 'paper':1, 'scissors':2}
    results = ['Draw!', 'Player 1 won!', 'Player 2 won!']
    return results[hand[p1] - hand[p2]]
'''