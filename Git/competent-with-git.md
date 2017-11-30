# Competent with GIT

## Staging
Adding changes

```
$ git add hello.html
$ git status
# On branch master
# Changes to be committed:
#   (use "git reset HEAD <file>..." to unstage)
#
#   modified:   hello.html
#
```
Changes to the hello.html have been staged. This means that git knows about the change, but it is not permanent in the repository. The next commit will include the changes staged.

Should you decide not to commit the change, the status command will remind you that you can use the git reset command to unstage these changes.

## Branching
To create a branch and switch to it at the same time, you can run the git checkout command with the -b switch:

```
$ git checkout -b iss53
Switched to a new branch 'iss53'
```

This is shorthand for:

```
$ git branch iss53
$ git checkout iss53
```

## Merging
Merging is Git's way of putting a forked history back together again. The git merge command lets you take the independent lines of development created by git branch and integrate them into a single branch.

```
git merge <branch>
```

## Conflicts

## Remotes
git remote - Manage set of tracked repositories

```
git remote [-v | --verbose]
git remote add [-t <branch>] [-m <master>] [-f] [--[no-]tags] [--mirror=<fetch|push>] <name> <url>
git remote rename <old> <new>
git remote remove <name>
git remote set-head <name> (-a | --auto | -d | --delete | <branch>)
git remote set-branches [--add] <name> <branch>…​
git remote get-url [--push] [--all] <name>
git remote set-url [--push] <name> <newurl> [<oldurl>]
git remote set-url --add [--push] <name> <newurl>
git remote set-url --delete [--push] <name> <url>
git remote [-v | --verbose] show [-n] <name>…​
git remote prune [-n | --dry-run] <name>…​
git remote [-v | --verbose] update [-p | --prune] [(<group> | <remote>)…​]
```

## Rebasing

## Revert
git revert - Revert some existing commits

The git revert command undoes a committed snapshot. But, instead of removing the commit from the project history, it figures out how to undo the changes introduced by the commit and appends a new commit with the resulting content. This prevents Git from losing history, which is important for the integrity of your revision history and for reliable collaboration.
```
git revert [--[no-]edit] [-n] [-m parent-number] [-s] [-S[<keyid>]] <commit>…​
git revert --continue
git revert --quit
git revert --abort
```

## Reset


## .gitignore
gitignore - Specifies intentionally untracked files to ignore

## .gitconfig

## git --help
git help - Display help information about Git