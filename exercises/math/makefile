Out.txt: math.exe
	mono $^ > $@

math.exe: math.cs
	mcs $^

.PHONEY:clean           # clean is a phoney target

clean:                           # a phoney target, no dependencies
	rm --force math.exe