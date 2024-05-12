package com.example.diceroller

import android.app.Activity
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import com.example.diceroller.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {
    private lateinit var binding:ActivityMainBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.button.setOnClickListener{
            rollDice()
        }
    }

    private fun rollDice(){
        val dice = Dice(numSides = 6)

        val dR = when(dice.diceRoll()){
            1 -> R.drawable.dice_one
            2 -> R.drawable.dice_two
            3 -> R.drawable.dice_three
            4 -> R.drawable.dice_four
            5 -> R.drawable.dice_five
            else -> R.drawable.dice_six
        }
        binding.imageView.setImageResource(dR)
    }

    class Dice(private val numSides : Int){
        fun diceRoll() : Int{
            return(1..numSides).random()
        }
    }
}