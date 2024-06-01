# Tally up points earned by games in tournament

def points(games):
    total_points = 0
    for game in games:
        our_points, their_points = game[0], game[2]
        if our_points > their_points:
            total_points += 3
        elif our_points == their_points:
            total_points += 1
    return total_points

print(points(['1:0','2:0','3:0','4:0','2:1','3:1','4:1','3:2','4:2','4:3'])) # 30