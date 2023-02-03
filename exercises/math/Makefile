Out.txt : main.exe
	mono $^ > $@

main.exe: main.cs
	mcs $^

.PHONEY:clean           		# clean is a phoney target

clean:                           # a phoney target, no dependencies
	rm --force Out.txt main.exe