# determine name of player from list

from dataclasses import dataclass


@dataclass
class Player:
    name: str


a_players = [Player(name) for name in "abcdcefghz"]


def duck_duck_goose(players, goose):
    return players[(goose + len(players) - 1) % len(players)].name


print(duck_duck_goose(a_players, 1))  # "a"
print(duck_duck_goose(a_players, 30))  # "z"
