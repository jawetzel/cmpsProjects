# CMPS290
# P02.asm
# Java Code:
# int[] myArray = {10, 20, 30, 40, 50};
# int n = 5;
# int i = 0;
# int sum = 0;
# System.out.println(" \nMy array elements are: ");
# for (i = 0; i < n; i += 1) {
# System.out.print(myArray[i] + "\t");
# sum += myArray[i];
# }
# System.out.print("\nSum of my array = " + sum);
	.data
myArray:.word 10, 20, 30, 40, 50
n: 	.word 5
i: 	.word 0
mes1: 	.asciiz "\nMy array elements are: \n"
mes2: 	.asciiz "\nSum of my array = "
newline:.asciiz "\n"
tab: 	.asciiz "\t"
	.text	
	
	lw $t4, n		#assigns word n to t4
	lw $t5, i		#assigns word i to t5
	
loopStart:
	la $t0, ($t5)		#assigns t0 to value of t5
	sll $t1, $t0, 2 	#multiplys t0 by 4 and asisgns to t1
	
	la  $t0, myArray	#assigns t0 to the address of myArray
	add $t2, $t0, $t1	#adds array address and value of t1 together and assigns to t2
	
	lw $t3, 0($t2)		#loads value of t2's value's address and asssigns it to t3 
	
	add $t6, $t6, $t3	#adds value of t3 to total held by t6
	
	add $t5, $t5, 1		#adds 1 to incriment
	beq $t4, $t5, loopEnd	#break loop mechanics 
	bne $t4, $t5, loopStart #stay in loop mechanic 
loopEnd:
	
	la $a0, ($t6) 		#saves value of total to a0
	li $v0, 1		#runs print intiger
	syscall			#runs print command
	
	li $v0, 10 # system call for exit
 	syscall #
