# CMPS290
# P01.asm
# read 2 integer numbers and print out the larger one

	.data 		#data section
mes1: 	.asciiz "\n\nEnter the first integer number: "
mes2: 	.asciiz "Enter the second integer number: "
mes3: 	.asciiz "The larger integer number is: "
	.text 		# code section
	
	la $a0, mes1		# print a string "mes1"	
	li $v0, 4
	syscall
	
	li $v0, 5		# read the 1st integer	
	syscall
	move $t1, $v0
	
	la $a0, mes2		# print a string "mes2"	
	li $v0, 4
	syscall
	
	li $v0, 5		# read the 2nd integer	
	syscall
	move $t2, $v0

	slt $t3, $t1, $t2	# Get larger integer (the first or the second)
	bne $t3, 1, oneGreater	# first number larger
	bne $t3, 0, twoGreater  # second number larger
	
	oneGreater: 
	la $t3, ($t1)		# path for first number greater
	j printOut
		
	twoGreater: 		#path for second number greater
	la $t3, ($t2)
	j printOut		
		
	printOut:
	la $a0 mes3 		# print a string "mes3"	
	li $v0, 4
	syscall
	
	la $a0, ($t3) 		 # print the larger int number
	li $v0, 1
	syscall
				# The program is finished.
 	li $v0, 10 		# system call for exit
 	syscall 		# exit!
