git fetch upstream
git rebase upstream/master

# if conflict, resolve issues, then run:
#	git rebase --continue
# if it tells you to skip then run:
#	git rebase --skip

....

....

# Always run this anyways to add the new items to source
git add -A :/

# Re-eval
git status

# Commit through IDE
# if it doesn't work...
git commit -m "message for commit"

# Push origin
git push origin master

# if the push fails....
# run:
git push -f origin master

# Pull Request via GitHub

