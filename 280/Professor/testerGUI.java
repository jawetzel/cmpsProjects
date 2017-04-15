package Professor;
import Professor.fileManager;

import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;
import javax.swing.JTextArea;
import javax.swing.JButton;
import javax.swing.JTextPane;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class testerGUI extends JFrame //class to test code
{

    private JPanel contentPane;

    /**
     * Launch the application.
     */
    public static void main(String[] args)
    {
	EventQueue.invokeLater(new Runnable()
	{
	    public void run()
	    {
		try
		{
		    testerGUI frame = new testerGUI();
		    frame.setVisible(true);
		} catch (Exception e)
		{
		    e.printStackTrace();
		}
	    }
	});
    }

    /**
     * Create the frame.
     */
    public testerGUI()
    {
    	setTitle("Test Driver"); //assigns jframe title
	setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); //endes program when exit button pressed
	setBounds(100, 100, 450, 108); //assigns size of frame
	contentPane = new JPanel(); //
	contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
	contentPane.setLayout(new BorderLayout(0, 0));
	setContentPane(contentPane);
	
	JButton btnNewButton = new JButton("Ok");  //creates ok button
	btnNewButton.addActionListener(new ActionListener()  //action for when ok button pressed
	{ //start when ok button pressed
	    public void actionPerformed(ActionEvent arg0) 
	    {
		fileManager file = new fileManager();
		file.openFile();  //opens data file
		file.readFile(); //reads data file and merges data into system
		file.closeFile(); //closes file
		file.printOutput(); //collects data from system and writes it into formated text file
		System.exit(0); //ends program
	    }
	});/*end when ok button pressed*/ 
	contentPane.add(btnNewButton, BorderLayout.CENTER); //centers text display box
	JTextPane txtpnPressOkTo = new JTextPane(); //setup box for text
	txtpnPressOkTo.setText("Press ok to Run Program, then check for the output file in the default location."); //text assigned to box
	contentPane.add(txtpnPressOkTo, BorderLayout.NORTH); //text box orientation
    }

}
