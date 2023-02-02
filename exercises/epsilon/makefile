out.txt : epsilon.exe
	mono $^ > $@

epsilon.exe : epsilon.cs
	mcs $^

clean:                         
	rm --force out.txt epsilon.exe