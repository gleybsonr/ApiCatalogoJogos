﻿using System;


namespace ApiCatalagoJogos.Exceptions
{
        public class JogoJaCadastradoException : Exception
        {
            public JogoJaCadastradoException()
                : base("Este já jogo está cadastrado")
            { }
        }
    }