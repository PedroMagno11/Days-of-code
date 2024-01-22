## Procurando Nemo

Você recebe uma série de palavras. Você precisa encontrar a palavra "Nemo" e retornar uma string como esta : `O Nemo foi encontrado na posição [posição onde a da palavra Nemo foi encontrada]!`.

Se você não conseguir encontrar o Nemo, retorne `Não consigo encontrar o Nemo :(`.

#### Exemplos

```text
procurandoNemo("Estou procurando o Nemo !") ➞ "O Nemo foi encontrado na posição 4!"

procurandoNemo("Nemo sou eu") ➞ "O Nemo foi encontrado na posição 1!"

procurandoNemo("Eu sou Nemo") ➞ "O Nemo foi encontrado na posição 3!"
```

---

### Notas

- `! , ? .` são sempre separados da última palavra.
- Nemo sempre se parecerá com Nemo, e não com NeMo ou outras variações maiúsculas.
- Nemo, ou qualquer coisa que diga Nemo com algo por trás, não conta como procurando Nemo.
- Se houver vários Nemo na frase, retorne apenas a posição do primeiro.
