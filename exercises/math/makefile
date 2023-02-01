Out.txt: math.exe
	mono $^ > $@

math.exe: math.cs
	mcs $^

clean:                           # a phoney target, no dependencies
	rm --force Out.txt math.exe