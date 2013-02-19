function displaynext(no)
        {
            cleartext(this);
            var ht;
            if (no == 2)
                ht = 275;
            else
                ht = 275 + ((no-2) * 75);

            document.getElementById('contents').style.height = ht + "px";
            
            switch (no) 
            {
                case 2:
                    {
                        document.getElementById('Medicine2').style.visibility = "visible";
                        var ht = document.getElementById('Medicine2').offsetHeight;
                        var top = document.getElementById('Medicine2').offsetTop;
                        document.getElementById('SnR').style.top = ht + top + "px";
                        break;
                    }
                case 3:
                    {
                        document.getElementById('Medicine3').style.visibility = "visible";
                        var ht = document.getElementById('Medicine3').offsetHeight;
                        var top = document.getElementById('Medicine3').offsetTop;
                        document.getElementById('SnR').style.top = ht + top + "px";
                        break;
                    }
                case 4:
                    {
                        document.getElementById('Medicine4').style.visibility = "visible";
                        var ht = document.getElementById('Medicine4').offsetHeight;
                        var top = document.getElementById('Medicine4').offsetTop;
                        document.getElementById('SnR').style.top = ht + top + "px";
                        break;
                    }
                case 5:
                    {
                        document.getElementById('Medicine5').style.visibility = "visible";
                        var ht = document.getElementById('Medicine5').offsetHeight;
                        var top = document.getElementById('Medicine5').offsetTop;
                        document.getElementById('SnR').style.top = ht + top + "px";
                        break;
                    }
                case 6:
                    {
                        document.getElementById('Medicine6').style.visibility = "visible";
                        var ht = document.getElementById('Medicine6').offsetHeight;
                        var top = document.getElementById('Medicine6').offsetTop;
                        document.getElementById('SnR').style.top = ht + top + "px";
                        break;
                    }
                case 7:
                    {
                        document.getElementById('Medicine7').style.visibility = "visible";
                        var ht = document.getElementById('Medicine7').offsetHeight;
                        var top = document.getElementById('Medicine7').offsetTop;
                        document.getElementById('SnR').style.top = ht + top + "px";
                        break;
                    }
                case 8:
                    {
                        document.getElementById('Medicine8').style.visibility = "visible";
                        var ht = document.getElementById('Medicine8').offsetHeight;
                        var top = document.getElementById('Medicine8').offsetTop;
                        document.getElementById('SnR').style.top = ht + top + "px";
                        break;
                    }
                case 9:
                    {
                        document.getElementById('Medicine9').style.visibility = "visible";
                        var ht = document.getElementById('Medicine9').offsetHeight;
                        var top = document.getElementById('Medicine9').offsetTop;
                        document.getElementById('SnR').style.top = ht + top + "px";
                        break;
                    }
                case 10:
                    {
                        document.getElementById('Medicine10').style.visibility = "visible";
                        var ht = document.getElementById('Medicine10').offsetHeight;
                        var top = document.getElementById('Medicine10').offsetTop;
                        document.getElementById('SnR').style.top = ht + top + "px";
                        break;
                    }
            }

        }           
        
        function changeHeight() 
        {  document.getElementById('contents').style.height = "200px"; }

        function cleartext(field)
        { field.value = ''; }       
        