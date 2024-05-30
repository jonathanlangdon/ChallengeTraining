# fix a greeting function where Johnny gets a special greeting


def greet(name):
    return f"Hello, {'my love' if name == 'Johnny' else name}!"


print(greet("Joe"))  # Hello, Joe!
print(greet("Johnny"))  # Hello, my love!
