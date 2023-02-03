out.txt : epsilon.exe
	mono $^ > $@

epsilon.exe : epsilon.cs
	mcs $^

.PHONEY:clean           # clean is a phoney target

clean:                         
	rm --force epsilon.exe