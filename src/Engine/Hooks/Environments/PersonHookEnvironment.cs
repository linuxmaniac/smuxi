// Smuxi - Smart MUltipleXed Irc
//
// Copyright (c) 2014 Mirco Bauer <meebey@meebey.net>
//
// Full GPL License: <http://www.gnu.org/licenses/gpl.txt>
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307 USA
using System;

namespace Smuxi.Engine
{
    public class PersonHookEnvironment : HookEnvironment
    {
        public PersonHookEnvironment(PersonModel person) :
                                this(null, person)
        {
        }

        public PersonHookEnvironment(string prefix, PersonModel person)
        {
            if (person == null) {
                throw new ArgumentNullException("person");
            }

            this[prefix + "PERSON_ID"] = person.ID;
            this[prefix + "PERSON_IDENTITY_NAME"] = person.IdentityName;
            this[prefix + "PERSON_NETWORK_ID"] = person.NetworkID;
            this[prefix + "PERSON_NETWORK_PROTOCOL"] = person.NetworkProtocol;
        }
    }
}