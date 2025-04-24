:- encoding(utf8).

% Предметная область – фильмы марвел

% главный герой

main(iron_man, 2).
main(iron_man_2, 2).
main(iron_man_3, 2).
main(spider_man_1, 1).
main(spider_man_2, 1).
main(spider_man_3, 1).
main(thor_1, 5).
main(thor_2, 5).
main(thor_3, 5).
main(thor_4, 5).
main(guardians_of_galaxy_1, 6).
main(guardians_of_galaxy_2, 6).
main(guardians_of_galaxy_3, 6).
main(ant_man, 7).
main(doctor_strange_1, 8).
main(doctor_strange_2, 8).
main(black_panther_1, 9).
main(black_panther_2, 9).
main(captain_marvel, 10).
main(black_widow, 4).
main(venom_1, 3).
main(venom_2, 3).
main(venom_3, 3).

% год выхода

year(iron_man, 1).
year(iron_man_2, 1).
year(iron_man_3, 2).
year(spider_man_1, 3).
year(spider_man_2, 3).
year(spider_man_3, 4).
year(thor_1, 1).
year(thor_2, 2).
year(thor_3, 3).
year(thor_4, 4).
year(guardians_of_galaxy_1, 2).
year(guardians_of_galaxy_2, 3).
year(guardians_of_galaxy_3, 4).
year(ant_man, 2).
year(doctor_strange_1, 3).
year(doctor_strange_2, 4).
year(black_panther_1, 3).
year(black_panther_2, 4).
year(captain_marvel, 3).
year(black_widow, 4).
year(venom_1, 3).
year(venom_2, 4).
year(venom_3, 3).

% дистрибьютор

dist(iron_man, 1).
dist(iron_man_2, 1).
dist(iron_man_3, 2).
dist(spider_man_1, 3).
dist(spider_man_2, 3).
dist(spider_man_3, 3).
dist(thor_1, 1).
dist(thor_2, 2).
dist(thor_3, 2).
dist(thor_4, 2).
dist(guardians_of_galaxy_1, 2).
dist(guardians_of_galaxy_2, 2).
dist(guardians_of_galaxy_3, 2).
dist(ant_man, 2).
dist(doctor_strange_1, 2).
dist(doctor_strange_2, 2).
dist(black_panther_1, 2).
dist(black_panther_2, 2).
dist(captain_marvel, 2).
dist(black_widow, 2).
dist(venom_1, 3).
dist(venom_2, 3).
dist(venom_3, 3).

% какая фаза

phase(iron_man, 1).
phase(iron_man_2, 1).
phase(iron_man_3, 2).
phase(spider_man_1, 3).
phase(spider_man_2, 3).
phase(spider_man_3, 4).
phase(thor_1, 1).
phase(thor_2, 2).
phase(thor_3, 3).
phase(thor_4, 4).
phase(guardians_of_galaxy_1, 2).
phase(guardians_of_galaxy_2, 3).
phase(guardians_of_galaxy_3, 5).
phase(ant_man, 2).
phase(doctor_strange_1, 3).
phase(doctor_strange_2, 4).
phase(black_panther_1, 3).
phase(black_panther_2, 4).
phase(captain_marvel, 3).
phase(black_widow, 4).
phase(venom_1, 3).
phase(venom_2, 4).
phase(venom_3, 5).

question1(X1):-	write("Кто главный герой вашего фильма?"), nl,
                write("1. Человек-паук"), nl,
                write("2. Железный человек"), nl,
                write("3. Веном"), nl,
                write("4. Черная вдова"), nl,
                write("5. Тор"), nl,
                write("6. Звездный лорд"), nl,
                write("7. Человек-муравей"), nl,
                write("8. Доктор Стрэндж"), nl,
                write("9. Черная пантера"), nl,
                write("10. Капитан Марвел"), nl,
                read(X1).

question2(X2):-	write("Когда вышел загаданный вами фильм?"), nl,
                write("1. 2008 - 2011"), nl,
                write("2. 2013 - 2015"), nl,
                write("3. 2016 - 2019"), nl,
                write("4. 2021 - 2025"), nl,
                read(X2).

question3(X3):-	write("Кто дистрибьютор вашего фильма?"), nl,
                write("1. Paramount Pictures"), nl,
                write("2. Disney"), nl,
                write("3. Sony Pictures"), nl,
                read(X3).

question4(X4):-	write("В какую фазу входит ваш фильм?"), nl,
                write("1. Первая"), nl,
                write("2. Вторая"), nl,
                write("3. Третья"), nl,
                write("4. Четвертая"), nl,
                write("5. Пятая"), nl,
                write("6. Шестая"), nl,
                read(X4).

pr:-	question1(X1), question2(X2), question3(X3), question4(X4),
 		main(Film, X1), year(Film, X2), dist(Film, X3), 
 		phase(Film, X4),
 		write("Фильм: "), write(Film), nl.