import nltk
from nltk.tokenize import word_tokenize
from nltk.corpus import stopwords
from nltk import Tree
import os
import sys



thefile = open('C:/Main Project/main/final/sentence.txt', 'r')
result = thefile.read()

stop_words = set(stopwords.words('english'))


text = word_tokenize(result)
text=[str(item) for item in text]
res = [w for w in text if not w in stop_words]



text = word_tokenize(result)
text=[str(item) for item in text]
tagged = nltk.pos_tag(text)
print( [str(item) for item in tagged])

nouns = [] #empty to array to hold all nouns
relatn= []
attr = []
pnouns = []

number = {'one':1,
     	'two':2,
        'three':3,
        'four':4,
        'five':5,
        'six':6,
        'seven':7,
        'eight':8,
        'nine':9,
        'ten':10,

        }


for word,pos in nltk.pos_tag(text):
    if (pos== 'NN' or pos=='IN' or  pos=='VBG' or  pos=='JJ'): #JJ VBD NNP
        relatn.append(word) 
            
    elif (pos=='CD'):
        objectcount=number[word]
        relatn.append(objectcount)

    elif (word=='a'or word=='an'):
        relatn.append(1)


    elif(pos == 'PRP' or pos == 'PRP$'):
        	pnouns.append(word)
for word,pos in nltk.pos_tag(res):
    if (pos == 'NN' or pos == 'NNS'):
        nouns.append(word)
    elif (pos=='JJ'):
        attr.append(word)

thisfile = open('C:/Main Project/main/final/objects.txt', 'w')
for item in nouns:
    thisfile.write("%s\t" % item)

thefile = open('C:/Main Project/main/final/rel.txt', 'w')
for item in relatn:
    thefile.write("%s\n" % item)

thefile = open('C:/Main Project/main/final/rel.txt', 'r')
relation_input = [line.rstrip('\n') for line in thefile]

    
length = len(relation_input)
for i in range (0,length,1):
    if relation_input[i].isdigit() and relation_input[i+1].isalpha():
        relation_input[i]=relation_input[i]+"."+relation_input[i+1]
        relation_input[i+1]='delete'
    else:
        relation_input[i]="1"+"."+relation_input[i]

relation_input = [ele for ele in relation_input if ele != '1.delete']

file = open('C:/Main Project/main/final/promptformatted.txt', 'w')
for item in relation_input:
    file.write("%s\n" % item)