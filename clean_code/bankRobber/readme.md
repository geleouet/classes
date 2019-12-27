# :gun: :clock230: Voleurs de banques :bank: :moneybag: :moneybag: :moneybag:


**_Medium_**

## Sujet

Une bande de voleurs décide de braquer une banque. Dans la banque il y a **_N_** coffres-forts;

Ce qu'ils savent sur les coffres :
- La combinaison du coffre est constituée de **_C_** caractères
- Les caractères sont les chiffres de 0 à **_D_**
- **_C_** et **_D_** peuvent être différents suivant les coffres

Tous les voleurs travaillent en même temps. 
Un voleur ne peut travailler que sur un coffre à la fois, et un seul voleur peut travailler par coffre en même temps.

La bande cherche à estimer le temps maximal nécessaire pour ouvrir tous les coffres.

Ils considèrent :
- Ils vont travailler sur les coffres suivant l'ordre des coffres. 
- Le temps pour passer d'un coffre à un autre est négligeable
- Le temps pour ouvrir un coffre dépend du nombre de combinaisons possibles, une seconde par combinaison.

Un voleur va tester les combinaisons possibles d'un coffre, à la vitesse d'une combinaison par seconde. 
Il essaie **toutes** les combinaisons (pour avoir le temps maximal).
Quand il a fini un coffre, il passe au coffre suivant disponible, suivant l'ordre de description des coffres. 

Le braquage est terminé lorsque tous les coffres sont ouverts.

## Exemples

_Exemple 1:_
```
- 1 voleur
- 1 coffre (C = 1, D = 5)

> 5s
```

_Exemple 2:_
```
- 1 voleur
- 1 coffre (C = 2, D = 5)

> 25s
```

_Exemple 3:_
```
- 2 voleurs
- 2 coffres (C = 2, D = 5) (C = 1, D = 5) 

> 25s
```

_Exemple 4:_
```
- 2 voleurs
- 3 coffres (C = 2, D = 5) (C = 1, D = 5) (C = 2, D = 5) 

> 30s
```

_Exemple 5:_
```
- 2 voleurs
- 5 coffres (C = 2, D = 5) (C = 1, D = 5) (C = 3, D = 5) (C = 1, D = 5) (C = 1, D = 5)  

> 130s
```


## Objectifs

Les objectifs de ce sujet sont :
- le domaine métier, on cherchera donc à modéliser le voleur, le coffre, etc...
- le découpage des responsabilitées
- l'immutabilté des données

