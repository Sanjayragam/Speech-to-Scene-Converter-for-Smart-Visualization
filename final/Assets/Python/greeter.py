import speech_recognition as sr
import nltk
from nltk.tokenize import word_tokenize
from gtts import gTTS
import os



r = sr.Recognizer()

with sr.Microphone() as source:
    r.adjust_for_ambient_noise(source)

    print("\nPlease say something")

    audio = r.listen(source)

    print("Converting your speech .... ")


    # recognize speech using google

  
    result =r.recognize_google(audio)

    thfile = open('sentence.txt', 'w')
    thfile.write("%s\n" % result)

    tts = gTTS(text=result, lang='en')
    tts.save("C:/Main Project/main/final/Assets/prompt.mp3")
    
  


    print("\nYou said: " + result)
    print ('\nTokenized result :')
    text = word_tokenize(result)
    text=[str(item) for item in text]
    tagged = nltk.pos_tag(text)
 

    print( [str(item) for item in tagged])
    nouns = [] #empty to array to hold all nouns
       

    for word,pos in nltk.pos_tag(text):
        if (pos == 'NN' or pos == 'JJ' ):
            nouns.append(word)
           
     
    print ("\n*************************OBJECTS & RELATIONS******************************") 
    print([str(item) for item in nouns])
    thefile = open('test.txt', 'w')
    for item in nouns:
        thefile.write("%s\n" % item)
    print('\n')
