import random as rd
aluninhos = ["manu", "gabu", "iago", "tigas", "maite", "bruno", "hemer", "andre", "fortunas", "felipe", "murilo", "joao", "freire", "falas", "caricas", "calica", "nycollas", "peter"]
while(len(aluninhos)>0): print(f"{aluninhos.pop(0)}, {aluninhos.pop(0)}, {aluninhos.pop(0)}") if rd.shuffle(aluninhos) == None else print("")