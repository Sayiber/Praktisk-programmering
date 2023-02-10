Out.txt : main.exe
	mono $^ > $@

main.exe: vec.dll
	mcs -target:exe -out:main.exe -reference:vec.dll main.cs

vec.dll : vec.cs
	mcs -target:library -out:vec.dll vec.cs 

clean:                           # a phoney target, no dependencies
	rm --force Out.txt main.exe vec.dll