package com.example.nipon.edittextinput;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

//        button
        final Button btn1 = (Button) findViewById(R.id.btnOk);



//        textview
        final TextView textV2 = (TextView) findViewById(R.id.txtV2);




//        input text
        final TextView editText1 = (TextView) findViewById(R.id.edtmsg);




//        perform action on click

        btn1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String strTxt = editText1.getText().toString();
                textV2.setText("Your msg = " + strTxt);
            }
        });






    }//void











}//main
