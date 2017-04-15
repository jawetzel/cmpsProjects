# CMPS290
# P03.asm
# C Code:
# int sumArray( int array[], int size ) 
# {
# 	if ( size == 0 )
# 		return 0;
# 	else
# 		return sumArray( array, size - 1 ) + array[ size - 1 ] ;
# }
#
# $a0 = array[], $a1 = size


	.data
myArray:.word 10, 20, 30, 40, 50
n:	.word 5
mes:	.asciiz "\nSum of my array = "
	.text

	la $a0, myArray		# assign myArray address to a0
	lw $a1, n		# assign value of n to a1
	
	jal Stack		# run subroutine Stack
Print:	
	la $a0, ($t6)		# print value of t6
	li $v0 1		# print number
	syscall			# activate print
	
	li $v0, 10 		# system call for exit
	syscall 		
 	
Stack:	addi 	$sp, $sp, -8	# adjust stack down 8 bits
	addi 	$t0, $a1, -1	# adjust counter down 1
	
	sw   	$t0, 0($sp)	# save new counter value to stack
	sw   	$ra, 4($sp)	# Save return value to stack
	
	bne  	$a1, $zero, Sum	# branch ! ( size == 0 )
	
	addi 	$sp, $sp, 8	# adjust stack up 8 on return
	jr 	$ra		# return to sum below jal stack

Sum:	move 	$a1, $t0	# sets a1 to new value of n
	jal 	Stack 		# runs stack subrutine for new n(lower by 1)
	
	lw 	$t0, 0($sp)	# stores value of top of stack to t0
	sll 	$t1, $t0, 2 	# multiplys t0 by 4 and assigns to t1
	add 	$t0, $t0, 1	# adds one to n for next iteration
	
	add 	$t1, $t1, $a0	# adds multiplier to array address to get correct number from array
	lw 	$t2, 0($t1)	# retrives value from array
	add 	$t6, $t6, $t2	# adds array value to total
	
	lw 	$ra, 4($sp)	# loads return address from stack        
	addi 	$sp, $sp, 8	# adjusts stack by 8 (pop 2 values)
	jr 	$ra		# returns to sum below stack  for next value until last in stack, the returns to print
