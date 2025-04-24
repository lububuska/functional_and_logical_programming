
high(ruby,1).
high(c_sharp,1).
high(python,1).
high(c_plus_plus,1).
high(f_sharp,1).
high(prolog,1).
high(c, 1).
high(asm,0).
high(golang,1). 
high(typescript,1). 
high(swift,1). 

decl(ruby,0).
decl(c_sharp,0).
decl(python,0).
decl(c_plus_plus,0).
decl(f_sharp,1).
decl(prolog,1).
decl(c,0).
decl(asm,0).
decl(golang,0).
decl(typescript,0).
decl(swift,0).

interpret(ruby,1).
interpret(c_sharp,0).
interpret(python,1).
interpret(c_plus_plus,0).
interpret(f_sharp,1).
interpret(prolog,1).
interpret(c,0).
interpret(asm,0).
interpret(golang,0).
interpret(typescript,1).
interpret(swift,0).

oop(ruby,3).
oop(c_sharp,3).
oop(python,2).
oop(c_plus_plus,2).
oop(f_sharp,1).
oop(prolog,1).
oop(c,0).
oop(asm,0).
oop(golang,1).
oop(typescript,3).
oop(swift,3).

cross(ruby,1).
cross(c_sharp,0).
cross(python,1).
cross(c_plus_plus,1).
cross(f_sharp,0).
cross(prolog,1).
cross(c,1).
cross(asm,1).
cross(golang,1).
cross(typescript,1).
cross(swift,0).

visual(ruby,2).
visual(c_sharp,3).
visual(python,2).
visual(c_plus_plus,2).
visual(f_sharp,2).
visual(prolog,1).
visual(c,0).
visual(asm,0).
visual(golang,1).
visual(typescript,3).
visual(swift,3).

mobile(ruby,0).
mobile(c_sharp,0).
mobile(python,0).
mobile(c_plus_plus,0).
mobile(f_sharp,0).
mobile(prolog,0).
mobile(c,0).
mobile(asm,0).
mobile(golang,1). 
mobile(typescript,1). 
mobile(swift,1). 

speed(asm, 3).       
speed(c, 3).        
speed(c_plus_plus, 3). 
speed(c_sharp, 2).   
speed(f_sharp, 2).   
speed(ruby, 1).      
speed(python, 1).   
speed(prolog, 0). 
speed(golang,3).
speed(typescript,1).
speed(swift,3).

question1(X1):-	write("Is your language high level?"),nl,
				write("1. Yes"),nl,
				write("0. NO"),nl,
				read(X1).

question2(X2):-	write("Is your language declarative?"),nl,
				write("1. Yes"),nl,
				write("0. NO"),nl,
				read(X2).

question3(X3):-	write("Is your language interpret?"),nl,
				write("1. Yes"),nl,
				write("0. NO"),nl,
				read(X3).

question4(X4):-	write("Does your language support OOP?"),nl,
				write("3. It is OOP itself"),nl,
				write("2. yes"),nl,
				write("1. yes, but very hard"),nl,
				write("0. NO"),nl,
				read(X4).

question5(X5):-	write("Is your language crossplatformic?"),nl,
				write("1. Yes"),nl,
				write("0. NO"),nl,
				read(X5).

question6(X6):-	write("Does your language support visual interface for user?"),nl,
				write("3. It is visual itself"),nl,
				write("2. yes"),nl,
				write("1. yes, but very hard"),nl,
				write("0. NO"),nl,
				read(X6).

question7(X7):-	write("Is your language for mobile phones?"),nl,
				write("1. Yes"),nl,
				write("0. NO"),nl,
				read(X7).	

question8(X8):-	write("How fast is your language?"),nl,
				write("3. Super fast"),nl,
				write("2. Fast enough"),nl,
				write("1. Slow"),nl,
				write("0. Super slow"),nl,
				read(X8).			

pr:-	question1(X1),question2(X2),question3(X3),question4(X4),
		question5(X5),question6(X6),question7(X7),question8(X8),
		high(X,X1),decl(X,X2),interpret(X,X3),oop(X,X4),
		cross(X,X5),visual(X,X6),mobile(X,X7),speed(X,X8)
		write(X).



