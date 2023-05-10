import speech_recognition as sr
import nltk
from nltk.tokenize import word_tokenize
from nltk.corpus import stopwords
from nltk import Tree
import os
import sys



stop_words = set(stopwords.words('english'))
# r = sr.Recognizer()
# with sr.Microphone() as source:
# 	print ('Say somethin dude!!!')
# 	audio = r.listen(source)
try:
    
    # result =r.recognize_google(audio)
    result="there is a car near the box"
    # print(result)
    
    thfile = open('C:/Main Project/main/final/sentence.txt', 'w')
    thfile.write("%s\n" % result)


    text = word_tokenize(result)
    text=[str(item) for item in text]
    res = [w for w in text if not w in stop_words]
 
    res = []
    for w in text:
    	if w not in stop_words:
    		res.append(w)
        
   

#     tagged = nltk.pos_tag(res)
#    # print( [str(item) for item in text])
#     print( [str(item) for item in tagged])


    text = word_tokenize(result)
    text=[str(item) for item in text]
    tagged = nltk.pos_tag(text)
    print( [str(item) for item in tagged])
    print(tagged)
    # print(text);

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
        'eleven':11,
        'a':1

        }


    for word,pos in nltk.pos_tag(text):
        if (pos== 'NN' or pos=='IN' or  pos=='VBG'): #JJ VBD
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


    # print(text)
    # print(res)
    # print(tagged)
    
    


    # print ("*************************OBJECTS & RELATIONS******************************")
    # print([str(item) for item in nouns])
    thisfile = open('C:/Main Project/main/final/objects.txt', 'w')
    for item in nouns:
        thisfile.write("%s\t" % item)

    # print ("*************************RELATIONS******************************")
    # print([str(item) for item in relatn])
    thefile = open('C:/Main Project/main/final/rel.txt', 'w')
    for item in relatn:
        thefile.write("%s\n" % item)

    print(relatn)



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

    print(relation_input)




except sr.UnknownValueError:
    print("Google Speech Recognition could not understand audio")
except sr.RequestError as e:
    print("Could not request results from Google Speech Recognition service; {0}".format(e))
