using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;
using UnityEngine;
using UnityEngine.Windows.Speech;
using UnityEngine.UI;

public class UserInputVoiceRecognizer : MonoBehaviour
{
	
	
	
	bool teclaPulsada = false;

	float windowTime = 1; 

	[SerializeField]
	    private Text m_Hypotheses;

	[SerializeField]
	    private Text m_Recognitions;

	    private DictationRecognizer m_DictationRecognizer;

	[SerializeField]
	    private string[] m_Keywords;

	    private KeywordRecognizer m_Recognizer; //el que le pasas la lista de palabras a reconocer
	    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    private void  OnPhraseRecognized(PhraseRecognizedEventArgs args){

    	StringBuilder builder = new StringBuilder();
        builder.AppendFormat("{0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
        builder.AppendFormat("\tTimestamp: {0}{1}", args.phraseStartTime, Environment.NewLine);
        builder.AppendFormat("\tDuration: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
        Debug.Log(builder.ToString());
    }
    // Update is called once per frame
    void Update()
    {

		
		if (Time.time - windowTime >= 1){
	        if(Input.GetKey(KeyCode.UpArrow)){

	        	if(teclaPulsada == false){

	        		teclaPulsada = true;
		        	m_Keywords = new string[4];
		       		m_Keywords.SetValue("Hello",0);
		        	m_Keywords.SetValue("Good",1);
		        	m_Keywords.SetValue("Football",2);
		        	m_Keywords.SetValue("Interfaces",3);

		        	m_Recognizer = new KeywordRecognizer(m_Keywords);

		        
		        	m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
		        	Debug.Log("Estoy empezando a escuchar ");
		        	m_Recognizer.Start();
		        	Debug.Log("Estoy terminando de escuchar ");
		        }
		        else if(teclaPulsada == true){

		        	m_DictationRecognizer.Stop();
		        	m_Recognizer.Dispose();

		        	Debug.Log("Tecla Pulsada,en m_Recognizer, true");
		        	teclaPulsada = false;

		        }

		        windowTime = Time.time;
		    } else if(Input.GetKey(KeyCode.DownArrow)) {
		    	if(teclaPulsada == false){
		    		teclaPulsada = true;
		        	m_DictationRecognizer = new DictationRecognizer();

			        m_DictationRecognizer.DictationResult += (text, confidence) =>
			        {
			        	try{
				            Debug.LogFormat("Dictation result: {0}", text);
				            m_Recognitions.text += text + "\n";
			        	}
			        	catch(Exception e){}
			        };

			        m_DictationRecognizer.DictationHypothesis += (text) =>
			        {
			        	try{
				            Debug.LogFormat("Dictation hypothesis: {0}", text);
				            m_Hypotheses.text += text;
			        	}
			        	catch(Exception e){}
			        };

			        m_DictationRecognizer.DictationComplete += (completionCause) =>
			        {
			            if (completionCause != DictationCompletionCause.Complete)
			                Debug.LogErrorFormat("Dictation completed unsuccessfully: {0}.", completionCause);
			        };

			        m_DictationRecognizer.DictationError += (error, hresult) =>
			        {
			            Debug.LogErrorFormat("Dictation error: {0}; HResult = {1}.", error, hresult);
			        };

			        m_DictationRecognizer.Start();

			        
			    }
			    else if(teclaPulsada == true){

			    	m_DictationRecognizer.Stop();
			    	m_DictationRecognizer.Dispose();

			    	Debug.Log("Tecla pulsada,m_DictationRecognizer,true");
			    	teclaPulsada = false;
			    }
			    windowTime = Time.time;
	        }

    	}
    }
}
