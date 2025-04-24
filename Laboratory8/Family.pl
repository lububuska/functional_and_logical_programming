% задание 1

% все мужчины
men:- man(X), print(X), nl, fail.

% все женщины
women:- woman(X), print(X), nl, fail.

% все дети некоторого родителя Х
children(X):- parent(X,Y), print(Y), nl, fail.

% проверка, является ли X матерью Y
mother(X,Y):- parent(X,Y), woman(X).

% мама X
mother(X):- parent(Y,X), woman(Y), print(Y).

% проверка, является ли X братом Y
brother(X,Y):- parent(Z,X), parent(Z,Y), man(X), X\=Y.

% братья X
brothers(X):- parent(Z,X), !, parent(Z,Y), man(Y), X\=Y, print(Y).

% проверка, являются ли X и Y родными братом и сестрой или братьями или сестрами.
b_s(X,Y):- parent(Z,X), parent(Z,Y), X\=Y.

% все братья или сестры X
b_s(X) :-
    setof(Y, b_s(X,Y), Siblings),
    forall(member(S, Siblings), (write(S), nl)).

% задание 2 вариант 1

% проверка, является ли X отцом Y

father(X,Y):- parent(X,Y), man(X).

% папа X
father(X):- parent(Y,X), man(Y), print(Y).

% проверка, является ли X сестрой Y
sister(X,Y):- parent(Z,X), parent(Z,Y), woman(X), X\=Y.

% сестры X
sisters(X):- parent(Z,X), !, parent(Z,Y), woman(Y), X\=Y, print(Y).

% задание 2 вариант 1

% проверка, является ли X дедушкой Y
grand_pa(X,Y):-parent(X,Z), parent(Z,Y), man(X).

% все дедушки X
grand_pa1(X):-grand_pa(Y,X), print(Y), nl, fail.
grand_pa2(X):-parent(Z,X), parent(Y,Z), man(Y), print(Y), nl, fail.

% проверка, является ли X и Y дедушкой и внуком или внуком и дедушкой.
grand_pa_and_son(X,Y):- (grand_pa(X, Y), man(Y)); (grand_pa(Y, X), man(X)), !.

% проверка, является ли X дядей Y
uncle1(X,Y):- parent(Z,Y), brother(X,Z).
uncle2(X,Y):- parent(Z,Y), parent(W,X), parent(W,Z), man(X), X\=W.

% все дяди X
uncles(X) :-
    setof(Y, uncle1(Y,X), Uncles),
    forall(member(U, Uncles), (write(U), nl)).