
namespace lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productWidth = new System.Windows.Forms.NumericUpDown();
            this.productLength = new System.Windows.Forms.NumericUpDown();
            this.productHeight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.productMaterial = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.productDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.countMoreTen = new System.Windows.Forms.RadioButton();
            this.countLessTen = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.producerOrganization = new System.Windows.Forms.TextBox();
            this.producerCountry = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.producerAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.producerPhone = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.loadData = new System.Windows.Forms.Button();
            this.saveData = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поСтранеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьРезультатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеотМКБToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.productWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productHeight)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление товара";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-9, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1077, 2);
            this.label2.TabIndex = 1;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(23, 84);
            this.productName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productName.MaxLength = 256;
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(193, 22);
            this.productName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.label3.Location = new System.Drawing.Point(227, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Название товара *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.label4.Location = new System.Drawing.Point(227, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Инвентарный номер *";
            // 
            // productNumber
            // 
            this.productNumber.Location = new System.Drawing.Point(23, 116);
            this.productNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productNumber.MaxLength = 256;
            this.productNumber.Name = "productNumber";
            this.productNumber.Size = new System.Drawing.Size(193, 22);
            this.productNumber.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.label5.Location = new System.Drawing.Point(227, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Размер (м)";
            // 
            // productWidth
            // 
            this.productWidth.Location = new System.Drawing.Point(23, 149);
            this.productWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productWidth.Name = "productWidth";
            this.productWidth.Size = new System.Drawing.Size(56, 22);
            this.productWidth.TabIndex = 10;
            // 
            // productLength
            // 
            this.productLength.Location = new System.Drawing.Point(92, 149);
            this.productLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productLength.Name = "productLength";
            this.productLength.Size = new System.Drawing.Size(56, 22);
            this.productLength.TabIndex = 11;
            // 
            // productHeight
            // 
            this.productHeight.Location = new System.Drawing.Point(161, 149);
            this.productHeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productHeight.Name = "productHeight";
            this.productHeight.Size = new System.Drawing.Size(56, 22);
            this.productHeight.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.label6.Location = new System.Drawing.Point(23, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "ширина";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.label7.Location = new System.Drawing.Point(91, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "длина";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.label8.Location = new System.Drawing.Point(157, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "высота";
            // 
            // productMaterial
            // 
            this.productMaterial.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.productMaterial.FormattingEnabled = true;
            this.productMaterial.ItemHeight = 17;
            this.productMaterial.Items.AddRange(new object[] {
            "Железо",
            "Пластмасса",
            "Древесина"});
            this.productMaterial.Location = new System.Drawing.Point(23, 209);
            this.productMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productMaterial.Name = "productMaterial";
            this.productMaterial.Size = new System.Drawing.Size(192, 38);
            this.productMaterial.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.label9.Location = new System.Drawing.Point(227, 228);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Вид материала";
            // 
            // productDate
            // 
            this.productDate.CustomFormat = "dd MMM yyyy";
            this.productDate.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.productDate.Location = new System.Drawing.Point(23, 299);
            this.productDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productDate.Name = "productDate";
            this.productDate.Size = new System.Drawing.Size(287, 24);
            this.productDate.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.label10.Location = new System.Drawing.Point(19, 276);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Дата поступления";
            // 
            // countMoreTen
            // 
            this.countMoreTen.AutoSize = true;
            this.countMoreTen.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.countMoreTen.Location = new System.Drawing.Point(23, 332);
            this.countMoreTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countMoreTen.Name = "countMoreTen";
            this.countMoreTen.Size = new System.Drawing.Size(176, 21);
            this.countMoreTen.TabIndex = 21;
            this.countMoreTen.TabStop = true;
            this.countMoreTen.Text = "количество больше 10";
            this.countMoreTen.UseVisualStyleBackColor = true;
            // 
            // countLessTen
            // 
            this.countLessTen.AutoSize = true;
            this.countLessTen.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.countLessTen.Location = new System.Drawing.Point(23, 361);
            this.countLessTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countLessTen.Name = "countLessTen";
            this.countLessTen.Size = new System.Drawing.Size(177, 21);
            this.countLessTen.TabIndex = 22;
            this.countLessTen.TabStop = true;
            this.countLessTen.Text = "количество меньше 10";
            this.countLessTen.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            this.label11.Location = new System.Drawing.Point(21, 405);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 21);
            this.label11.TabIndex = 23;
            this.label11.Text = "Производитель";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(19, 394);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 2);
            this.label12.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.label13.Location = new System.Drawing.Point(227, 439);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Организация";
            // 
            // producerOrganization
            // 
            this.producerOrganization.Location = new System.Drawing.Point(23, 434);
            this.producerOrganization.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.producerOrganization.MaxLength = 64;
            this.producerOrganization.Name = "producerOrganization";
            this.producerOrganization.Size = new System.Drawing.Size(193, 22);
            this.producerOrganization.TabIndex = 25;
            // 
            // producerCountry
            // 
            this.producerCountry.FormattingEnabled = true;
            this.producerCountry.Items.AddRange(new object[] {
            "Россия",
            "Беларусь",
            "Украина",
            "Польша",
            "Болгария",
            "Литва",
            "Латвия",
            "Румыния"});
            this.producerCountry.Location = new System.Drawing.Point(23, 468);
            this.producerCountry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.producerCountry.Name = "producerCountry";
            this.producerCountry.Size = new System.Drawing.Size(193, 24);
            this.producerCountry.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.label14.Location = new System.Drawing.Point(227, 471);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "Страна";
            // 
            // producerAddress
            // 
            this.producerAddress.Location = new System.Drawing.Point(23, 503);
            this.producerAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.producerAddress.MaxLength = 256;
            this.producerAddress.Name = "producerAddress";
            this.producerAddress.Size = new System.Drawing.Size(315, 22);
            this.producerAddress.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.label15.Location = new System.Drawing.Point(347, 507);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "Адрес";
            // 
            // producerPhone
            // 
            this.producerPhone.Location = new System.Drawing.Point(23, 538);
            this.producerPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.producerPhone.Mask = "+000 (00) 000-00-00";
            this.producerPhone.Name = "producerPhone";
            this.producerPhone.Size = new System.Drawing.Size(147, 22);
            this.producerPhone.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift SemiLight", 8.25F);
            this.label16.Location = new System.Drawing.Point(180, 542);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "Номер телефона";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 585);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 48);
            this.button1.TabIndex = 34;
            this.button1.Text = "Добавить товар";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.makeOrder);
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBox.Location = new System.Drawing.Point(411, 117);
            this.outputBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputBox.Size = new System.Drawing.Size(613, 440);
            this.outputBox.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F);
            this.label17.Location = new System.Drawing.Point(907, 84);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 21);
            this.label17.TabIndex = 36;
            this.label17.Text = "База данных";
            // 
            // loadData
            // 
            this.loadData.Location = new System.Drawing.Point(807, 585);
            this.loadData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(219, 48);
            this.loadData.TabIndex = 37;
            this.loadData.Text = "Выгрузить";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // saveData
            // 
            this.saveData.Location = new System.Drawing.Point(580, 585);
            this.saveData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(219, 48);
            this.saveData.TabIndex = 38;
            this.saveData.Text = "Сохранить";
            this.saveData.UseVisualStyleBackColor = true;
            this.saveData.Click += new System.EventHandler(this.saveData_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.aboutProgram,
            this.сортировкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 662);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // aboutProgram
            // 
            this.aboutProgram.Name = "aboutProgram";
            this.aboutProgram.Size = new System.Drawing.Size(118, 24);
            this.aboutProgram.Text = "О программе";
            this.aboutProgram.Click += new System.EventHandler(this.aboutProgram_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поСтранеToolStripMenuItem,
            this.поДатеотМКБToolStripMenuItem,
            this.поДатеToolStripMenuItem,
            this.поНазваниюТовараToolStripMenuItem,
            this.сохранитьРезультатToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поСтранеToolStripMenuItem
            // 
            this.поСтранеToolStripMenuItem.Name = "поСтранеToolStripMenuItem";
            this.поСтранеToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.поСтранеToolStripMenuItem.Text = "По стране";
            this.поСтранеToolStripMenuItem.Click += new System.EventHandler(this.поСтранеToolStripMenuItem_Click);
            // 
            // поДатеToolStripMenuItem
            // 
            this.поДатеToolStripMenuItem.Name = "поДатеToolStripMenuItem";
            this.поДатеToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.поДатеToolStripMenuItem.Text = "По дате (от б. к м.)";
            this.поДатеToolStripMenuItem.Click += new System.EventHandler(this.поДатеToolStripMenuItem_Click);
            // 
            // поНазваниюТовараToolStripMenuItem
            // 
            this.поНазваниюТовараToolStripMenuItem.Name = "поНазваниюТовараToolStripMenuItem";
            this.поНазваниюТовараToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.поНазваниюТовараToolStripMenuItem.Text = "По названию товара";
            this.поНазваниюТовараToolStripMenuItem.Click += new System.EventHandler(this.поНазваниюТовараToolStripMenuItem_Click);
            // 
            // сохранитьРезультатToolStripMenuItem
            // 
            this.сохранитьРезультатToolStripMenuItem.Name = "сохранитьРезультатToolStripMenuItem";
            this.сохранитьРезультатToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.сохранитьРезультатToolStripMenuItem.Text = "Сохранить результат";
            this.сохранитьРезультатToolStripMenuItem.Click += new System.EventHandler(this.сохранитьРезультатToolStripMenuItem_Click);
            // 
            // поДатеотМКБToolStripMenuItem
            // 
            this.поДатеотМКБToolStripMenuItem.Name = "поДатеотМКБToolStripMenuItem";
            this.поДатеотМКБToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.поДатеотМКБToolStripMenuItem.Text = "По дате (от м. к б.)";
            this.поДатеотМКБToolStripMenuItem.Click += new System.EventHandler(this.поДатеотМКБToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 690);
            this.Controls.Add(this.saveData);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.producerPhone);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.producerAddress);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.producerCountry);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.producerOrganization);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.countLessTen);
            this.Controls.Add(this.countMoreTen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.productDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.productMaterial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productHeight);
            this.Controls.Add(this.productLength);
            this.Controls.Add(this.productWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Приложение";
            ((System.ComponentModel.ISupportInitialize)(this.productWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productHeight)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown productWidth;
        private System.Windows.Forms.NumericUpDown productLength;
        private System.Windows.Forms.NumericUpDown productHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox productMaterial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker productDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton countMoreTen;
        private System.Windows.Forms.RadioButton countLessTen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox producerOrganization;
        private System.Windows.Forms.ComboBox producerCountry;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox producerAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox producerPhone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button loadData;
        private System.Windows.Forms.Button saveData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgram;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДатеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНазваниюТовараToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поСтранеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьРезультатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДатеотМКБToolStripMenuItem;
    }
}

