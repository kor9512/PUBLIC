DROP TABLE BST;

CREATE TABLE BST (
  N INTEGER NOT NULL, 
  P INTEGER 
);

INSERT INTO BST(N, P) values(1, 2);
INSERT INTO BST(N, P) values(3, 2);
INSERT INTO BST(N, P) values(9, 8);
INSERT INTO BST(N, P) values(2, 5);
INSERT INTO BST(N, P) values(8, 5);
INSERT INTO BST(N, P) values(5, null);

SELECT * FROM bst;

SELECT N,
	CASE 
		WHEN isnull(P)
			THEN 'Root'
		WHEN N NOT IN (
				SELECT P 
				FROM (SELECT N,P FROM BST) AS A
				WHERE P iS not null
				GROUP BY P
				ORDER BY N)
			THEN 'Leaf'
		ELSE 'Inner'
	END AS PP FROM BST
ORDER BY N ASC;


