CREATE TABLE dogs (
  id INTEGER NOT NULL PRIMARY KEY, 
  name VARCHAR(50) NOT NULL
);

CREATE TABLE cats (
  id INTEGER NOT NULL PRIMARY KEY, 
  name VARCHAR(50) NOT NULL
);

INSERT INTO dogs(id, name) values(1, 'Lola');
INSERT INTO dogs(id, name) values(2, 'Bella');
INSERT INTO cats(id, name) values(1, 'Lola');
INSERT INTO cats(id, name) values(2, 'Kitty');

select name from dogs 
union distinct 
select name from cats;