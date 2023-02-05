Out.txt : main.exe
	mono $^ > $@

main.exe: main.cs vec.dll
	mcs -target:exe -out:main.exe -reference:vec.dll main.cs

clean:                           # a phoney target, no dependencies
	rm --force Out.txt main.exe vec.dll