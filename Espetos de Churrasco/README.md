## Churrasqueira

Você é o responsável por uma churrasqueira. Um **espeto vegetariano** é um espeto que tem **somente vegetais (-o)**. Um espeto de carne tem **pelo menos um pedaço de carne (-x)**.

Por exemplo:
A churrasqueira abaixo tem **4 espetos de carne** e **1 espeto vegetariano** (o espeto do meio).

```text
["--xo--x--ox--",
"--xx--x--xx--",
"--oo--o--oo--",      <<< espeto vegetariano
"--xx--x--ox--",
"--xx--x--ox--"]
```

#### Exemplo

Dada uma churrasqueira, escreva uma função que retorne `[# quantidade de espetos vegetarianos, # quantidade de espetos de carne]`.

Por exemplo, com base na churrasqueira acima, a função deve retornar `[1, 4]`. 

```text
 [
  "--oooo-ooo--",
  "--xx--x--xx--",
  "--o---o--oo--",
  "--xx--x--ox--",
  "--xx--x--ox--"
] ➞ [2, 3]

[
  "--oooo-ooo--",
  "--xxxxxxxx--",
  "--o---",
  "-o-----o---x--",
  "--o---o-----"
) ➞ [3, 2]
```

