-- find comma position in characteristics column of monster table


CREATE TABLE monsters (
    id SERIAL PRIMARY KEY,
    name VARCHAR(255),
    legs INT,
    arms INT,
    characteristics VARCHAR(255)
);

INSERT INTO monsters (name, legs, arms, characteristics) VALUES
('Goblin', 2, 2, 'green,small'),
('Ogre', 2, 2, 'large,brutish'),
('Dragon', 4, 0, 'fire-breathing,flying'),
('Troll', 2, 2, 'large,regenerative'),
('Vampire', 2, 2, 'undead,bloodsucking'),
('Werewolf', 2, 2, 'lycanthropic,transforms'),
('Ghost', 0, 0, 'ethereal,invisible'),
('Zombie', 2, 2, 'undead,brain-eating'),
('Ghoul', 2, 2, 'undead,corpse-eating'),
('Banshee', 0, 0, 'screaming,spirit'),
('Phoenix', 2, 2, 'firebird,rebirth'),
('Cyclops', 2, 1, 'one-eyed,giant'),
('Kraken', 0, 8, 'tentacled,sea-monster'),
('Griffin', 4, 2, 'eagle-headed,winged'),
('Chimera', 4, 2, 'multi-headed,hybrid');

SELECT id, name, POSITION(',' IN characteristics) AS comma 
FROM monsters
ORDER BY comma;