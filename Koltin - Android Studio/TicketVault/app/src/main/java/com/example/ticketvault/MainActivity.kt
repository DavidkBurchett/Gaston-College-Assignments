package com.example.ticketvault

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.EditText
import android.widget.Spinner
import android.widget.TextView

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        val spinner: Spinner = findViewById(R.id.spinner)
        ArrayAdapter.createFromResource(
            this,R.array.concerts_array,android.R.layout.simple_spinner_item).also{
                adapter -> adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item)
            spinner.adapter = adapter
            }

        val num1 = findViewById<EditText>(R.id.numoftickets)
        val tot = findViewById<TextView>(R.id.txtresult)

        val clickme = findViewById<Button>(R.id.costbutton)

        clickme.setOnClickListener{
            val val1 =  num1.text.toString().toInt()
            val price = 79.99
            val result = val1 * price
            tot.setText(result.toString())
        }
    }
}