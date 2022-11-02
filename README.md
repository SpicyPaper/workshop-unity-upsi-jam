# Introduction

Workshop Unity donné à certains participants de la UPsi Jam, qui est une Game Jam que j'organise 1-2 fois par année dans les locaux de la HE-Arc.

L'objectif de ce workshop est de transmettre aux participants les bases et les bonnes pratiques de la création d'un jeu vidéo avec Unity. Ce workshop a également pour but de fournir un point de départ aux participants afin de leur permettre de participer à la Game Jam qui suit ce workshop en ayant acquis les bases.

# Explication des branches

## Branches générales

-   main : la branche contenant la version du README le plus à jour
-   solution : la branche contenant le projet qui sera réalisé durant le workshop et les notes de cours

# Prérequis

1. Télécharger Visual Studio 2022 https://visualstudio.microsoft.com/fr/downloads/ (si vous avez Visual Studio 2019 il n’est pas nécessaire d’installer VS 2022)
2. Attendre la fin de l’installation de VS, car il sera nécessaire dans les prochaines étapes.
3. Une fois VS installé, télécharger le Unity Hub https://unity3d.com/get-unity/download
4. Une fois le Hub installé, il faut l’ouvrir et aller dans l’onglet `installs`, puis cliquer sur le bouton `install editor` et installer la version `LTS` la plus récente (au moment de la rédaction de ce document il s'agit de la version `2021.3.12f1` LTS, mais toute autre version LTS `2021.x.x` fera l'affaire).
5. Une fois Unity installé, ouvrir l’onglet `Projects` et cliquer sur `new project`.
6. Sélectionner la bonne version de Unity (Editor Version) et sélectionner `2D (URP)`.
7. Donner un nom au projet `UPsiJam_WorkshopUnity` ou tout autre nom et cliquer sur `Create project`.
8. Attendre que le projet Unity s’ouvre, cela peut prendre plusieurs minutes dépendant du PC.
9. Une fois le projet ouvert, il faut paramétrer Unity pour utiliser VS comme IDE. Pour ce faire aller dans `Edit/Preferences/External Tools` et dans le champ `External Script Editor`, sélectionner la version de VS qui a été installée.
10. Si aucune erreur n’est survenue durant ce processus c’est que vous êtes prêt à suivre le workshop. Sinon essayez de résoudre le problème et si vous ne trouvez pas de solution par vous-même, contactez-moi au moins 24h avant l’événement, car il ne sera pas possible d’aider les gens le jour même.

# Erreurs courantes

## Une erreur survient au moment de la création d'un nouveau projet

Cela peut provenir de beaucoup de choses, mais il est possible que cela soit dû à un autre programme qui empêche Unity de fonctionner correctement.  
J'ai personnellement déjà eu le problème avec PowerToys, il suffit de terminer le processus et de tenter à nouveau de créer un projet Unity, cela devrait fonctionner.  
D'autres programmes pourraient être la cause de ce problème, essayez de terminer le processus des autres programmes qui tournent en tâche de fond et des autres programmes dont vous n'avez pas besoin à la création d'un projet Unity.  
Si cela ne résoud pas le problème, cela pourrait provenir d'autre chose, essayez de copier coller l'erreur dans Google.
