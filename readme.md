# Always run this anyways to add the new items to source
git add -A :/

# Re-eval
git status

# Commit through IDE
# if it doesn't work...
git commit -m "message for commit"

# Re-eval
git status

# re-init the delta
git fetch upstream

# re-init the #head to my changes latest
git rebase upstream/master

# If conflict, resolve issues, then run:
git rebase --continue
# Or, if it tells you to skip then run:
git rebase --skip

....

# Re-eval
git status

....

# Push origin
git push origin master

# Re-eval
git status

# if the push fails....
# run:
git push -f origin master

# Pull Request via GitHub

