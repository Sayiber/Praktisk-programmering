Out.txt : main.exe
	mono $^ > $@

main.exe : main.cs
	mcs $^

.PHONEY:clean           # clean is a phoney target

clean:                         
	rm --force Out.txt main.exe