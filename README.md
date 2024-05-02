Word Wrap
---------

We need a method for wrapping text to a maximum number of columns like you get in a text editor window
with word wrap turned on. 

## When window is wider than the text 
...then text is on one line.

## When window is narrower than the text 
... then text is wrapped (by inserting new line (`\n`) characters) before the word that would cause the 
line to be too long.

Note: While the window is wider than any single word, word wrap should ensure that:

1) no line is longer than the window width 
2) no word is split
3) the first column contains the fist character of a word

e.g. if window width = 7 columns

Input: `This is a test`
Output: 
```
This<SPACE> 
is a<SPACE>
test
```

The string `This is` is 7 characters but word wrap should split before `is` so that the 
first char of the new line is the beginning of a new word and not a space.

Note: This is how notepad++ behaves (and probably others as well)

## When the window is narrower than a word
...then the word is split at the window width.

e.g. if window width = 3 columns

Input: `This is a test`
Output:
```
Thi
s<SPACE>
is<SPACE>
a<SPACE>
tes
t
```