# UsandoThreads
O que é uma thread (Linha de execução) ?

Vejamos algumas definições:

Linha de execução (em inglês: Thread), é uma forma de um processo dividir a si mesmo em duas ou mais tarefas que podem ser executadas concorrentemente. O suporte à thread é fornecido pelo próprio sistema operacional (SO), no caso da linha de execução ao nível do núcleo (em inglês: Kernel-Level Thread (KLT)), ou implementada através de uma biblioteca de uma determinada linguagem, no caso de uma User-Level Thread (ULT).

Uma linha de execução permite que o usuário de programa, por exemplo, utilize uma funcionalidade do ambiente enquanto outras linhas de execução realizam outros cálculos e operações.
http://pt.wikipedia.org/wiki/Thread_(ci%C3%AAncia_da_computa%C3%A7%C3%A3o)
"Uma Thread é Um fluxo de controle sequencial isolado dentro de um programa"
Como um programa sequencial qualquer, um thread tem um começo, um fim, e uma seqüência de comandos. Entretanto, um thread não é um programa, não roda sozinho, roda dentro de um programa.
Threads permitem que um programa simples possa executar várias tarefas diferentes ao mesmo tempo, independentemente umas das outras. Programas multi-threaded são programas que contém vários threads, executando tarefas distintas, ao mesmo tempo.

Métodos  	  Descrição
Start -	Faz com que uma thread seja agendado para execução.

Lock -	Bloqueia os recursos até que a thread que o esta usando acabe de processá-lo.

Join -	Bloqueia o segmento de chamada até que um thread seja encerrado.

Sleep -	Bloqueia o corrente thread pelo número especificado de milissegundos


