# OptServer  🌍.
_Backend server web_

**Objectif:**

Ecrire le backend d'un service web qui suit l'API suivante

> [API definition](https://app.swaggerhub.com/apis/geleouet.meritis/OptServer/1.0#/default/postValue)

Telecharger le serveur testeur et valider son implementation
> [Serveur](https://github.com/geleouet/serverTestServer/releases)

Le service web implémente un interpréteur à pile

> **Pile d'origine**
> /dataset

> {

>   name : "mon dataset",

>   datas : ["A", "B", "C", "D"]

> }

>
>
>|A  
>|-
>|B  
>|C
>|D

 
## Opérations :
> **ADDITION**
>  
>|A + B
>|-
>|C
>|D


> **MULTIPLICATION**
> 
>|A * B
>|-
>|C
>|D


> **NEGATION**
> 
>| -( A )
>|-
>|B
>|C
>|D


> **CONDITION**
> 
>| si (A > 0)  alors  B sinon C
>|-
>|D





