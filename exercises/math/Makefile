Out.txt : main.exe
	mono $^ > $@

main.exe: sfuns.dll
	mcs -target:exe -out:main.exe -reference:sfuns.dll main.cs

sfuns.dll : sfuns.cs
	mcs -target:library -out:sfuns.dll sfuns.cs 

.PHONEY:clean           		# clean is a phoney target

clean:                           # a phoney target, no dependencies
	rm --force Out.txt main.exe sfuns.dll