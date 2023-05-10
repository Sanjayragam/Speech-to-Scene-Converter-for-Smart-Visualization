
with open('C:/Main Project/main/final/rel.txt') as f:
    relation_input = [line.rstrip('\n') for line in f]

length = len(relation_input)
print(relation_input)
for i in range (0,length,1):
    if relation_input[i].isdigit() and relation_input[i+1].isalpha():
        relation_input[i]=relation_input[i]+"."+relation_input[i+1]
        relation_input[i+1]='delete'

relation_input = [ele for ele in relation_input if ele != 'delete']

thisfile = open('C:/Main Project/main/final/promptformatted.txt', 'w')
for item in relation_input:
    thisfile.write("%s\n" % item)












# number = {'one':1,
#      	'two':2,
#         'three':3,
#         'four':4,
#         'five':5,
#         'six':6,
#         'seven':7,
#         'eight':8,
#         'nine':9,
#         'ten':10,

#         }


# if relatn[0]=='six' and relatn[1]=='apple':
#     relatn[0]=str(number[relatn[0]])+'.'+relatn[1]
#     relatn.remove(relatn[1])

# print(relatn)