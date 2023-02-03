default: test-shell Out.txt

Out.txt : main.exe              # out.txt depends on hello.exe
	mono main.exe > Out.txt 

main.exe : main.cs             # hello.exe depends on hello.cs
	mcs main.cs             	 

.PHONEY:clean           # clean is a phoney target

clean:                           # a phoney target, no dependencies
	rm --force Out.txt main.exe

test-shell:
	echo $$0