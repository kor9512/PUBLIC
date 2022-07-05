CREATE TABLE enrollments (
  id INTEGER NOT NULL PRIMARY KEY, 
  year INTEGER NOT NULL,
  studentId INTEGER NOT NULL
);

INSERT INTO enrollments(id, year, studentId) values(1,	2003, 1);
INSERT INTO enrollments(id, year, studentId) values(20,	2000, 2);
INSERT INTO enrollments(id, year, studentId) values(100,2000, 3);
INSERT INTO enrollments(id, year, studentId) values(110,2016, 4);

update enrollments set year=2015 where id BETWEEN 20 and 100;
