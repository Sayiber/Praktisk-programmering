## Practical Programming 2023 

*Kevin Bach Gravesen*




## Pull changes made on other system

```
git fetch origin
git status
```

If you get the status "Your branch is behind 'origin/master' by x commit, and can be fast-forwarded." use 
```
git pull
```

If 
```
error: Your local changes to the following files would be overwritten by merge:
    file_name
Please, commit your changes or stash them before you can merge.
Aborting
```

Commit your local changes

```
git add .
git commit -m ‘Commit msg’
```

Try to get the changes (will fail)

```
git pull
```

will report something like:

```
Pull is not possible because you have unmerged files.
Please, fix them up in the work tree, and then use 'git add/rm <file>'
as appropriate to mark resolution, or use 'git commit -a'.
```

Open the conflict file and fix the conflict. Then:

```
git add .
git commit -m ‘Fix conflicts’
git pull
```

will report something like:

```
Already up-to-date.
```
