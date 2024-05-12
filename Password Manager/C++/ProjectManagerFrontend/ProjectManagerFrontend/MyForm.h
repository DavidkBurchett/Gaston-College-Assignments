#pragma once
#include <string>
#include <sqlite3.h>
#include <iostream>
#include <msclr\marshal_cppstd.h>

namespace PasswordManagerDatabaseViewer{

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace std;

	static string convertSystemString(System::String^ stringToConvert);
	static int selectData(const char* s);
	static int wireUpPasswordList(void* NotUsed, int argc, char** argv, char** azColName);
	static int deleteData(const char* s, string id);
	static int insertData(const char* s, string application);
	const char* directory = "C:\\Users\\Zu98\\OneDrive - Gaston College\\Password Manager\\passwordManager.db";
	sqlite3* DB;

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			

			InitializeComponent();
			selectData(directory);
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ buttonRefresh;
	private: System::Windows::Forms::Button^ buttonDelete;
	private: System::Windows::Forms::TextBox^ textBoxDelete;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::TextBox^ textBoxAdd;
	private: System::Windows::Forms::Button^ buttonAdd;

	protected:



	protected:


	protected:

	protected:

	protected:

	protected:

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->buttonRefresh = (gcnew System::Windows::Forms::Button());
			this->buttonDelete = (gcnew System::Windows::Forms::Button());
			this->textBoxDelete = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->textBoxAdd = (gcnew System::Windows::Forms::TextBox());
			this->buttonAdd = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// buttonRefresh
			// 
			this->buttonRefresh->Location = System::Drawing::Point(15, 105);
			this->buttonRefresh->Name = L"buttonRefresh";
			this->buttonRefresh->Size = System::Drawing::Size(75, 23);
			this->buttonRefresh->TabIndex = 0;
			this->buttonRefresh->Text = L"Refresh";
			this->buttonRefresh->UseVisualStyleBackColor = true;
			this->buttonRefresh->Click += gcnew System::EventHandler(this, &MyForm::buttonRefresh_Click);
			// 
			// buttonDelete
			// 
			this->buttonDelete->Location = System::Drawing::Point(121, 163);
			this->buttonDelete->Name = L"buttonDelete";
			this->buttonDelete->Size = System::Drawing::Size(75, 23);
			this->buttonDelete->TabIndex = 1;
			this->buttonDelete->Text = L"Delete";
			this->buttonDelete->UseVisualStyleBackColor = true;
			this->buttonDelete->Click += gcnew System::EventHandler(this, &MyForm::buttonDelete_Click);
			// 
			// textBoxDelete
			// 
			this->textBoxDelete->Location = System::Drawing::Point(15, 163);
			this->textBoxDelete->Name = L"textBoxDelete";
			this->textBoxDelete->Size = System::Drawing::Size(100, 20);
			this->textBoxDelete->TabIndex = 2;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(12, 9);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(0, 13);
			this->label1->TabIndex = 3;
			this->label1->Text = L"Use this application to view all entries in the database, add new entries,\nor remove entries by ID.This is mainly to ensure the databse is working\ncorrectly without having to first install a sqlite database application.If the\ndatabase is not working as intended, an application to edit the sqlite\ndatabase should be installed.";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(12, 89);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(79, 13);
			this->label2->TabIndex = 4;
			this->label2->Text = L"Refresh Entries";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(12, 147);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(93, 13);
			this->label3->TabIndex = 5;
			this->label3->Text = L"Delete Entry by ID";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(12, 211);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(229, 13);
			this->label4->TabIndex = 6;
			this->label4->Text = L"Add new entry (text box is for application name)";
			// 
			// textBoxAdd
			// 
			this->textBoxAdd->Location = System::Drawing::Point(15, 227);
			this->textBoxAdd->Name = L"textBoxAdd";
			this->textBoxAdd->Size = System::Drawing::Size(100, 20);
			this->textBoxAdd->TabIndex = 7;
			// 
			// buttonAdd
			// 
			this->buttonAdd->Location = System::Drawing::Point(121, 225);
			this->buttonAdd->Name = L"buttonAdd";
			this->buttonAdd->Size = System::Drawing::Size(75, 23);
			this->buttonAdd->TabIndex = 8;
			this->buttonAdd->Text = L"Add";
			this->buttonAdd->UseVisualStyleBackColor = true;
			this->buttonAdd->Click += gcnew System::EventHandler(this, &MyForm::buttonAdd_Click);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(365, 295);
			this->Controls->Add(this->buttonAdd);
			this->Controls->Add(this->textBoxAdd);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->textBoxDelete);
			this->Controls->Add(this->buttonDelete);
			this->Controls->Add(this->buttonRefresh);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::FixedSingle;
			this->MaximizeBox = false;
			this->Name = L"MyForm";
			this->Text = L"Database Viewer";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
		private: System::Void MyForm_Load(System::Object^ sender, System::EventArgs^ e) {
		}

		//these are the button functionalites
		private: System::Void buttonRefresh_Click(System::Object^ sender, System::EventArgs^ e) {
			selectData(directory);
		}


		private: System::Void buttonDelete_Click(System::Object^ sender, System::EventArgs^ e) {
		deleteData(directory, convertSystemString(textBoxDelete->Text));
		selectData(directory);
		}


		private: System::Void buttonAdd_Click(System::Object^ sender, System::EventArgs^ e) {
		insertData(directory, convertSystemString(textBoxAdd->Text));
		selectData(directory);
		}
	};

	//used to convert the strings from the form, because we need std strings
	static string convertSystemString(System::String^ stringToConvert) {
		msclr::interop::marshal_context context;
		return context.marshal_as<string>(stringToConvert);
	}

	//below here is all SQL related queries
	static int selectData(const char* s) {
		sqlite3* DB;

		int exit = sqlite3_open(s, &DB);

		string sql = "SELECT * FROM passwords;";

		sqlite3_exec(DB, sql.c_str(), wireUpPasswordList, NULL, NULL);

		return 0;
	}

	static int deleteData(const char* s, string id) {
		sqlite3* DB;

		int exit = sqlite3_open(s, &DB);

		string sql = "DELETE FROM passwords WHERE id = " + id + ";";

		sqlite3_exec(DB, sql.c_str(), NULL, NULL, NULL);

		return 0;
	}

	static int insertData(const char* s, string application) {
		sqlite3* DB;

		int exit = sqlite3_open(s, &DB);

		string sql = "INSERT INTO passwords (application, password) VALUES ('" + application + "', ' ');";

		sqlite3_exec(DB, sql.c_str(), NULL, NULL, NULL);

		return 0;
	}

	static int wireUpPasswordList(void* NotUsed, int argc, char** argv, char** azColName) {
		for (int i = 0; i < argc; i++) {
			cout << azColName[i] << ": " << argv[i] << endl;
			
		}

		cout << endl;

		return 0;
	}
}
