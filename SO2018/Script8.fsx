open System.Xml
open System.Xml.Serialization
open System.IO

let xml = """
    <?xml version="1.0" encoding="utf-8"?>
<Root>
    <Periodical subscription="true" issues_per_year="47">
        <Title>The New Yorker</Title>
        <Website>newyorker.com</Website>

        <Edition available="true" date="2018-04-16">
            <Contributor>Junot Diaz</Contributor>
            <Contributor>Louisa Thomas</Contributor>
            <Contributor>D. T. Max </Contributor>
            <!-- More contributors omitted -->
        </Edition>

        <Edition available="true" date="...">
            <Contributor>David Remnick</Contributor>
            <Contributor>Malcolm Gladwell</Contributor>
            <!-- More contributors omitted -->
        </Edition>

       <!-- More editions omitted -->
    </Periodical>
    <Other>
        <Foo>Foo</Foo>
        <Foo>Bar</Foo>
    </Other>
</Root>
"""

[<CLIMutable>]
type Edition = {
    [<XmlAttribute("available")>] Available : bool
    [<XmlAttribute("date")>]   Date : string
    [<XmlElement>]   Contributor : string [] // What goes here? 
}

[<CLIMutable>]
[<System.Xml.Serialization.XmlRootAttribute(Namespace="Root", 
                 IsNullable=false)>]
type Periodical = {
    [<XmlAttribute("subscription")>]      Subscription : bool
    [<XmlAttribute("issues_per_year")>]   IssuesPerYear: int
    [<XmlElement>] Title: string
    [<XmlElement>] Website : string
    [<XmlElement>] Edition : Edition []   // What goes here?
}

let  xRoot = XmlRootAttribute();
xRoot.ElementName <- ""


let Deserialize<'T> file rootnode =
    file |> File.ReadAllText
         |> (fun data -> new StringReader(data))
         |> (new System.Xml.Serialization.XmlSerializer(typeof<'T>, new System.Xml.Serialization.XmlRootAttribute(rootnode))).Deserialize
// let Deserialize<'T> (file: string) rootnode =
//     file
//     |> (new System.Xml.Serialization.XmlSerializer(typeof<'T>, new System.Xml.Serialization.XmlRootAttribute(rootnode))).Deserialize

Deserialize<Periodical> @"C:\tmp\ny.xml" "Root" :?> Periodical