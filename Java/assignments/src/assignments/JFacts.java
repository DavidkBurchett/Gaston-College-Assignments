package assignments;

import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Random;

import javax.swing.*;

public class JFacts extends JFrame implements ActionListener{
	
	JLabel border = new JLabel("************************************************************");
	JButton button = new JButton("Press to change fact");
	JLabel fact = new JLabel("facts appear here");
	final int WIDTH = 350;
	final int HEIGHT = 150;
	String[] facts = {"fact1", "fact2", "fact3", "fact4", "fact5", "fact6", "fact7", "fact8", "fact9", "fact10"};
	Random random = new Random();
	
	public JFacts() {
		super("Facts");
		setSize(WIDTH, HEIGHT);
		setLayout(new FlowLayout());
		add(button);
		add(border);
		add(fact);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		button.addActionListener(this);
	}
	
	public static void main(String[] args) {
		JFacts factFrame = new JFacts();
		factFrame.setVisible(true);
	}
	

	public void actionPerformed(ActionEvent e) {
		int factNum = random.nextInt(facts.length);
		fact.setText(facts[factNum]);
	}

}
