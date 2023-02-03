out.txt : hello.exe              # out.txt depends on hello.exe
	mono hello.exe > out.txt 

hello.exe : hello.cs             # hello.exe depends on hello.cs
	mcs hello.cs             	 

.PHONEY:clean           # clean is a phoney target

clean:                           # a phoney target, no dependencies
	rm --force hello.exe