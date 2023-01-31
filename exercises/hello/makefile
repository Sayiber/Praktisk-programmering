out.txt : hello.exe              # out.txt depends on hello.exe
	mono hello.exe > out.txt 

hello.exe : hello.cs             # hello.exe depends on hello.cs
	mcs hello.cs             	 

clean:                           # a phoney target, no dependencies
	rm --force out.txt hello.exe