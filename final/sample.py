import nltk
from nltk.tokenize import word_tokenize
from nltk.corpus import stopwords
from nltk import Tree
import os
import sys



f = open('C:/Main Project/main/final/sentence.txt', 'r')
sentence = f.read()
sentence = sentence.split(".")
# print(sentence)
count=-1
for item in sentence:
    count=count+1
# print(count)

if count==0:
    count=1
    
sent_count = open('C:/Main Project/main/final/count.txt', 'w')
sent_count.write("%s" % count)

nouns = [] #empty to array to hold all nouns

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



for i in range(0,count,1):
    filenumber=str(i+1)
    path="C:/Main Project/main/final/promptformatted"+filenumber+".txt"
    relatn= []
    # print(sentence[i])
    result = sentence[i]
    stop_words = set(stopwords.words('english'))
    text = word_tokenize(result)
    text=[str(item) for item in text]
    res = [w for w in text if not w in stop_words]
    text = word_tokenize(result)
    text=[str(item) for item in text]
    tagged = nltk.pos_tag(text)
    print( [str(item) for item in tagged])

    for word,pos in nltk.pos_tag(text):
        if (pos== 'NN' or pos=='IN' or  pos=='VBG' or  pos=='JJ'): #JJ VBD NNP
            relatn.append(word) 

        elif (pos=='CD'):
            objectcount=str(number[word])
            relatn.append(objectcount)

        elif (word=='a'or word=='an'):
            relatn.append(str(1))
    # print(relatn) 

    length = len(relatn)
    # print(length)

    relation_input=[]
    relation_input=relatn

    # print(relation_input)

    for i in range (0,length,1):
        if relation_input[i].isdigit() and relation_input[i+1].isalpha():
            relation_input[i]=relation_input[i]+"."+relation_input[i+1]
            relation_input[i+1]='delete'
        else:
            relation_input[i]="1"+"."+relation_input[i]
    relation_input = [ele for ele in relation_input if ele != '1.delete']

    print(relation_input)


    
    file = open(path, 'w')

    for item in relation_input:
        file.write("%s\n" % item)

