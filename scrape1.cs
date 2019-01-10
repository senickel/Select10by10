/*
            // Debug.WriteLine(sq1.full[Array.IndexOf(sq1.geo_order, 1)].ToString());
            int top = 100;
            int left = 300;
            int count = 35;
            int index = new int();
            List<TwoColorButton> buttons = new List<TwoColorButton>();
            for (int i = 0; i < 100; i++)
            {
                if (sq1.geo_order.Contains(i + 1))
                {
                    index = Array.IndexOf(sq1.geo_order, i + 1);
                    TwoColorButton newButton = new TwoColorButton();
                    newButton.Name = "added_button_" + index.ToString();
                    newButton.index = i;
                    newButton.geo_order = sq1.geo_order[index];
                    newButton.stateCounter = sq1.full[index];
                    newButton.BackColor = states[sq1.full[index]];
                    newButton.Width = 34;
                    newButton.Height = 34;
                    newButton.Text = sq1.subunit_name[index].Split('@')[3];
                    newButton.subunit = sq1.subunit_name[index];
                    newButton.unit = sq1.name;
                    newButton.Left = left;
                    newButton.Top = top;
                    buttons.Add(newButton);
                    this.Controls.Add(newButton);
                }
                if ((i + 1) % 10 == 0)
                {
                    top = top + count;
                    left = 300;
                }
                else
                {
                    left = left + count;
                }


            }
            */